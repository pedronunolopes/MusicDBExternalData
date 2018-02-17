package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MUArtistMediaRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUArtistMediaRecord> {

	private static final GlobalObjectKey Idt_MUArtistMedia = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*YAsu+kK36uFTXWvbB8dPmQ");

	public static void ensureInitialized() {}
	public ENt_MUArtistMediaEntityRecord ssENt_MUArtistMedia;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUArtistMediaEntityRecord toStructure() {
		return ssENt_MUArtistMedia;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUArtistMediaRecord(ENt_MUArtistMediaEntityRecord r) throws Exception {
		ssENt_MUArtistMedia = (ENt_MUArtistMediaEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUArtistMedia.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUArtistMedia.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUArtistMediaRecord() {
		OptimizedAttributes = null;
		ssENt_MUArtistMedia = new ENt_MUArtistMediaEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUArtistMedia.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUArtistMedia.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUArtistMedia.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MUArtistMedia.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MUArtistMediaRecord r) throws Exception {
		this.ssENt_MUArtistMedia = (ENt_MUArtistMediaEntityRecord) r.ssENt_MUArtistMedia.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MUArtistMediaRecord)) {
			return false;
		}
		RCt_MUArtistMediaRecord b = (RCt_MUArtistMediaRecord) obj;
		if (!this.ssENt_MUArtistMedia.equals(b.ssENt_MUArtistMedia)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MUArtistMedia.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUArtistMedia.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUArtistMedia.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUArtistMediaRecord duplicate() throws Exception {
		RCt_MUArtistMediaRecord t = new RCt_MUArtistMediaRecord();
		t.ssENt_MUArtistMedia = (ENt_MUArtistMediaEntityRecord) this.ssENt_MUArtistMedia.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MUArtistMedia.toXml(this, recordElem, "t_MUArtistMedia", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muartistmedia")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUArtistMedia")) variable.setValue(ssENt_MUArtistMedia); else variable.setOptimized(true);
			variable.setFieldName("t_muartistmedia");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUArtistMediaRecord t = (RCt_MUArtistMediaRecord) super.clone();
		t.ssENt_MUArtistMedia = (ENt_MUArtistMediaEntityRecord) this.ssENt_MUArtistMedia.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistMedia.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistMedia.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUArtistMedia)) {
			return ssENt_MUArtistMedia;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUArtistMedia.fillFromOther((IRecord) other.attributeGet(Idt_MUArtistMedia));
	}
}
