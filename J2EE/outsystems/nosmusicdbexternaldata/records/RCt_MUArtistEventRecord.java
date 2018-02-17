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


public class RCt_MUArtistEventRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUArtistEventRecord> {

	private static final GlobalObjectKey Idt_MUArtistEvent = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*ZmTJuuuJnkDNj1gFNdaiVQ");

	public static void ensureInitialized() {}
	public ENt_MUArtistEventEntityRecord ssENt_MUArtistEvent;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUArtistEventEntityRecord toStructure() {
		return ssENt_MUArtistEvent;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUArtistEventRecord(ENt_MUArtistEventEntityRecord r) throws Exception {
		ssENt_MUArtistEvent = (ENt_MUArtistEventEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUArtistEvent.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUArtistEvent.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUArtistEventRecord() {
		OptimizedAttributes = null;
		ssENt_MUArtistEvent = new ENt_MUArtistEventEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(4, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUArtistEvent.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUArtistEvent.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUArtistEvent.OptimizedAttributes;
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
		index = ssENt_MUArtistEvent.read(r, index);
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
	public void readIM(RCt_MUArtistEventRecord r) throws Exception {
		this.ssENt_MUArtistEvent = (ENt_MUArtistEventEntityRecord) r.ssENt_MUArtistEvent.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MUArtistEventRecord)) {
			return false;
		}
		RCt_MUArtistEventRecord b = (RCt_MUArtistEventRecord) obj;
		if (!this.ssENt_MUArtistEvent.equals(b.ssENt_MUArtistEvent)) return false;
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
			return super.hashCode() ^ ssENt_MUArtistEvent.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUArtistEvent.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUArtistEvent.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUArtistEventRecord duplicate() throws Exception {
		RCt_MUArtistEventRecord t = new RCt_MUArtistEventRecord();
		t.ssENt_MUArtistEvent = (ENt_MUArtistEventEntityRecord) this.ssENt_MUArtistEvent.duplicate();
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
			ssENt_MUArtistEvent.toXml(this, recordElem, "t_MUArtistEvent", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muartistevent")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUArtistEvent")) variable.setValue(ssENt_MUArtistEvent); else variable.setOptimized(true);
			variable.setFieldName("t_muartistevent");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUArtistEventRecord t = (RCt_MUArtistEventRecord) super.clone();
		t.ssENt_MUArtistEvent = (ENt_MUArtistEventEntityRecord) this.ssENt_MUArtistEvent.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistEvent.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistEvent.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUArtistEvent)) {
			return ssENt_MUArtistEvent;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUArtistEvent.fillFromOther((IRecord) other.attributeGet(Idt_MUArtistEvent));
	}
}
