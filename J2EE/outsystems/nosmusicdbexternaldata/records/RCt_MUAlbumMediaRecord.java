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


public class RCt_MUAlbumMediaRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUAlbumMediaRecord> {

	private static final GlobalObjectKey Idt_MUAlbumMedia = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*Ak+mpjR6jzDLHAt52X5gaw");

	public static void ensureInitialized() {}
	public ENt_MUAlbumMediaEntityRecord ssENt_MUAlbumMedia;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUAlbumMediaEntityRecord toStructure() {
		return ssENt_MUAlbumMedia;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUAlbumMediaRecord(ENt_MUAlbumMediaEntityRecord r) throws Exception {
		ssENt_MUAlbumMedia = (ENt_MUAlbumMediaEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUAlbumMedia.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUAlbumMedia.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUAlbumMediaRecord() {
		OptimizedAttributes = null;
		ssENt_MUAlbumMedia = new ENt_MUAlbumMediaEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUAlbumMedia.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUAlbumMedia.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUAlbumMedia.OptimizedAttributes;
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
		index = ssENt_MUAlbumMedia.read(r, index);
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
	public void readIM(RCt_MUAlbumMediaRecord r) throws Exception {
		this.ssENt_MUAlbumMedia = (ENt_MUAlbumMediaEntityRecord) r.ssENt_MUAlbumMedia.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MUAlbumMediaRecord)) {
			return false;
		}
		RCt_MUAlbumMediaRecord b = (RCt_MUAlbumMediaRecord) obj;
		if (!this.ssENt_MUAlbumMedia.equals(b.ssENt_MUAlbumMedia)) return false;
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
			return super.hashCode() ^ ssENt_MUAlbumMedia.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUAlbumMedia.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUAlbumMedia.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUAlbumMediaRecord duplicate() throws Exception {
		RCt_MUAlbumMediaRecord t = new RCt_MUAlbumMediaRecord();
		t.ssENt_MUAlbumMedia = (ENt_MUAlbumMediaEntityRecord) this.ssENt_MUAlbumMedia.duplicate();
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
			ssENt_MUAlbumMedia.toXml(this, recordElem, "t_MUAlbumMedia", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mualbummedia")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUAlbumMedia")) variable.setValue(ssENt_MUAlbumMedia); else variable.setOptimized(true);
			variable.setFieldName("t_mualbummedia");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUAlbumMediaRecord t = (RCt_MUAlbumMediaRecord) super.clone();
		t.ssENt_MUAlbumMedia = (ENt_MUAlbumMediaEntityRecord) this.ssENt_MUAlbumMedia.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUAlbumMedia.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUAlbumMedia.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUAlbumMedia)) {
			return ssENt_MUAlbumMedia;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUAlbumMedia.fillFromOther((IRecord) other.attributeGet(Idt_MUAlbumMedia));
	}
}
